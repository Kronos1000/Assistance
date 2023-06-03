import React, { useEffect, useState } from 'react';
import {
  Box,
  Button,
  Center,
  Flex,
  Heading,
  Text,
  Textarea
} from '@chakra-ui/react';

export const DashboardRight = () => {
  const [selectedVendor, setSelectedVendor] = useState(1);
  const [vendors, setVendors] = useState([]);
  const [vehicles, setVehicles] = useState([]);
  const [newVehicleName, setNewVehicleName] = useState('');
  const [newVehicleType, setNewVehicleType] = useState('');
  const [newVehicleDesc, setNewVehicleDesc] = useState('');
  const [newVendorID, setNewVendorID] = useState('');
  const [newVehicleID, setNewVehicleID] = useState('');

  function handleButtonClick(vehicleID) {
    setSelectedVendor(vehicleID);
  }

  function addData() {
    // Redirect to the addvehicles.html page or handle the addition of data in your preferred way
    window.location.href = './addvehicles.html';
  }

  function handleDeleteVehicle(vehicleID) {
    fetch(`${process.env.REACT_APP_BACKEND_URL}/vehicles/${vehicleID}`, {
      method: 'DELETE',
    })
      .then(res => {
        if (res.ok) {
          setVehicles(vehicles.filter(v => v.vehicleID !== vehicleID));
        } else {
          console.log('Failed to delete vehicle');
        }
      })
      .catch(err => console.log(err));
  }

  useEffect(() => {
    if (vendors.length === 0) {
      fetch(`${process.env.REACT_APP_BACKEND_URL}/vendors`)
        .then(res => res.json())
        .then(body => setVendors(body))
        .catch(err => console.log(err));
    }

    if (vehicles.length === 0) {
      fetch(`${process.env.REACT_APP_BACKEND_URL}/vehicles`)
        .then(res => res.json())
        .then(body => setVehicles(body))
        .catch(err => console.log(err));
    }
  }, []);

  function handleAddVehicle() {
    fetch(`${process.env.REACT_APP_BACKEND_URL}/vehicles`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({
        vehicleName: newVehicleName,
        vehicleType: newVehicleType,
        vehicleDescription: newVehicleDesc,
        VendorID: newVendorID,
      }),
    })
      .then(res => res.json())
      .then(body => {
        setVehicles([...vehicles, body]);
        // log info to console
        console.log(body);
        // Reset the form fields after successful addition
        setNewVehicleName('');
        setNewVehicleType('');
        setNewVehicleDesc('');
        setNewVendorID('');
        setNewVehicleID('');
      })
      .catch(err => console.log(err));
  }

  return (
    <Flex>
      <Box paddingLeft={200} paddingTop={140}>
        <Heading> Vehicles</Heading>
        <br />
        <br />

        {vehicles.map(v => {
          return (
            <Flex key={v.vehicleID} alignItems="center">
              <Center>
                <Text>
                  Vehicle Name: {v.vehicleName} <br />
                  {/* Description: {v.vehicleDescription} <br /> */}
                  <br />
                </Text>
                <br />
                <br />
                {/* <Button ml={4} colorScheme="yellow" size="sm">
                  edit
                </Button> */}
                <Button
                  ml={4}
                  colorScheme="red"
                  size="sm"
                  onClick={() => handleDeleteVehicle(v.vehicleID)}
                >
                  Delete
                </Button>
              </Center>
              <br />
              <br />
            </Flex>
          );
        })}

        <Heading> Add New Car </Heading>
        <Box marginTop={4}>
          <Textarea
            type="text"
            placeholder="Vehicle Name"
            value={newVehicleName}
            onChange={e => setNewVehicleName(e.target.value)}
          />

          <Textarea
            type="text"
            placeholder="Vehicle Type"
            value={newVehicleType}
            onChange={e => setNewVehicleType(e.target.value)}
          />

          <br />
          <br />

          <Textarea
            type="text"
            placeholder="Vehicle Description"
            value={newVehicleDesc}
            onChange={e => setNewVehicleDesc(e.target.value)}
          />

          <br />
          <br />

          <Textarea
            type="text"
            placeholder="Vendor ID"
            value={newVendorID}
            onChange={e => setNewVendorID(e.target.value)}
          />

          <br />
          <br />

          <Button w={'60%'} onClick={handleAddVehicle} colorScheme={'green'}>
            Add Vehicle Item
          </Button>
        </Box>
      </Box>
    </Flex>
  );
};
