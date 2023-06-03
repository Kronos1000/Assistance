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

export const DashboardLeft= () => {
  const [selectedVendor, setSelectedVendor] = useState(1);
  const [vendors, setVendors] = useState([]);
  const [furnitures, setFurnitures] = useState([]);
  const [newFurnitureName, setNewFurnitureName] = useState('');
  const [newFurnitureType, setNewFurnitureType] = useState('');
  const [newFurnitureDesc, setNewFurnitureDesc] = useState('');
  const [newVendorID, setNewVendorID] = useState('');
  const [newFurnitureID, setNewFurnitureID] = useState('');

  function handleButtonClick(vendorID) {
    setSelectedVendor(vendorID);
  }

  function addData() {
    // Redirect to the addfurnitures.html page or handle the addition of data in your preferred way
    window.location.href = './addfurnitures.html';
  }

  function handleDeleteFurniture(furnitureID) {
    fetch(`${process.env.REACT_APP_BACKEND_URL}/furnitures/${furnitureID}`, {
      method: 'DELETE',
    })
      .then(res => {
        if (res.ok) {
          setFurnitures(furnitures.filter(f => f.furnitureID !== furnitureID));
        } else {
          console.log('Failed to delete furniture');
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

    if (furnitures.length === 0) {
      fetch(`${process.env.REACT_APP_BACKEND_URL}/furnitures`)
        .then(res => res.json())
        .then(body => setFurnitures(body))
        .catch(err => console.log(err));
    }
  }, []);

  function handleAddFurniture() {
    fetch(`${process.env.REACT_APP_BACKEND_URL}/furnitures`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({
        furnitureName: newFurnitureName,
        furnitureType: newFurnitureType,
        furnitureDescription: newFurnitureDesc,
        VendorID: newVendorID,
      }),
    })
      .then(res => res.json())
      .then(body => {
        setFurnitures([...furnitures, body]);
        // log info to console
        console.log(body);
        // Reset the form fields after successful addition
        setNewFurnitureName('');
        setNewFurnitureType('');
        setNewFurnitureDesc('');
        setNewVendorID('');
        setNewFurnitureID('');
      })
      .catch(err => console.log(err));
  }

  return (
    <Flex>
      <Box paddingLeft={200} paddingTop={140}>
      {/* <br />
        <br />
        <br />
        <br /> */}
<Heading> Furniture</Heading>
        <br />
        <br />

      
        {furnitures.map(f => {
          return (
            <Flex key={f.furnitureID} alignItems="center">
              <Center>
                <Text>
                  Furniture Name: {f.furnitureName} <br />
                  {/* Description: {f.furnitureDescription} <br /> */}
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
                  onClick={() => handleDeleteFurniture(f.furnitureID)}
                >
                  Delete
                </Button>
              </Center>
              <br />
              <br />
            </Flex>
          );
        })}
   
        <Heading> Add New Furniture Item </Heading>
        <Box marginTop={4}>
          <Textarea
            type="text"
            placeholder="Furniture Name"
            value={newFurnitureName}
            onChange={e => setNewFurnitureName(e.target.value)}
          />

          <Textarea
            type="text"
            placeholder="Furniture Type"
            value={newFurnitureType}
            onChange={e => setNewFurnitureType(e.target.value)}
          />

          <br />
          <br />

          <Textarea
            type="text"
            placeholder="Furniture Description"
            value={newFurnitureDesc}
            onChange={e => setNewFurnitureDesc(e.target.value)}
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

          <Button w={'60%'} onClick={handleAddFurniture} colorScheme={'green'}>
            Add Furniture 
          </Button>
        </Box>
      </Box>
    </Flex>
  );
};
