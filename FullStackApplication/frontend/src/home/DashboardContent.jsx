import React, { useEffect, useState } from 'react';
import { Box, Button, Center, Flex, Heading, Text } from '@chakra-ui/react';

export const DashboardContent = () => {
  const [selectedVendor, setSelectedVendor] = useState(1);
  const [vendors, setVendors] = useState([]);
  const [foods, setFoods] = useState([]);
  const [newFoodName, setNewFoodName] = useState('');
  const [newFoodType, setNewFoodType] = useState('');
  const [newFoodDesc, setNewFoodDesc] = useState('');
  const [newVendorID, setNewVendorID] = useState('');
  const [newFoodID, setNewFoodID] = useState('');

  function handleButtonClick(vendorID) {
    setSelectedVendor(vendorID);
  }

  function addData() {
    // Redirect to the addfoods.html page or handle the addition of data in your preferred way
    window.location.href = './addfoods.html';
  }

  function handleDeleteFood(foodID) {
    fetch(`${process.env.REACT_APP_BACKEND_URL}/foods/${foodID}`, {
      method: 'DELETE',
    })
      .then(res => {
        if (res.ok) {
          setFoods(foods.filter(f => f.foodID !== foodID));
        } else {
          console.log('Failed to delete food');
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

    if (foods.length === 0) {
      fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`)
        .then(res => res.json())
        .then(body => setFoods(body))
        .catch(err => console.log(err));
    }
  }, []);

  function handleAddFood() {
    fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({
        // foodID: newFoodID,
        foodName: newFoodName,
        foodType: newFoodType,
        FoodDescription: newFoodDesc,
        vendorID: newVendorID,
      }),
    })
      .then(res => res.json())
      .then(body => {
        setFoods([...foods, body]);
        // log info to console
        console.log(body);
        // Reset the form fields after successful addition
        setNewFoodName('');
        setNewFoodType('');
        setNewFoodDesc('');
        setNewVendorID('');
        setNewFoodID('');
      })
      .catch(err => console.log(err));
  }

  // Page content
  return (
    <Flex>
      <Box paddingLeft={100}>
        <Center>
          <Heading> The magical emporium </Heading>
        </Center>
        <Center>
          <Text fontSize="lg">Inventory</Text>
        </Center>

        <br />
        <br />

        <Heading size="md">Vendors</Heading>

        {vendors.map(vendor => (
          <Flex key={vendor.id} alignItems="center">
            <Center>
              <Text>Vendor Name: {vendor.name}</Text>
              <br></br>
              <Text> Vendor ID: {vendor.vendorID}</Text>
            </Center>
          </Flex>
        ))}

        <br />
        <br />

        <Heading size="md">Food</Heading>

        {foods.map(f => {
          return (
            <Flex key={f.foodID} alignItems="center">
              <Center>
                <Text>Food Name: {f.foodName}   Food ID: {f.foodID} </Text>
                <br></br>
            	<br></br>
        
                <Text> Vendor ID:{f.vendorID} </Text>
                <br />
                <br />
                <Button ml={4} colorScheme="yellow" size="sm">
                  edit
                </Button>
                <Button
                  ml={4}
                  colorScheme="red"
                  size="sm"
                  onClick={() => handleDeleteFood(f.foodID)}
                >
                  Delete
                </Button>
              </Center>
              <br />
              <br />
            </Flex>
          );
        })}
      </Box>
    </Flex>
  );
};
