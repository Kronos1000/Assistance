import React, { useEffect, useState } from 'react';
import { Box, Button, Center, Flex, Heading } from '@chakra-ui/react';

export const DashboardCenter = () => {
  const [selectedVendor, setSelectedVendor] = useState(1);
  const [foods, setFoods] = useState([]);
  const[foodID,setFoodID] = useState('0');
  const [newFoodName, setNewFoodName] = useState('');
  const [newFoodType, setNewFoodType] = useState('');
  const [newFoodDesc, setNewFoodDesc] = useState('');
  const [vendor, setVendor] = useState([]);

  function handleButtonClick(vendorID) {
    setSelectedVendor(vendorID);
    fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`)
      .then(res => res.json())
      .then(body => setFoods(body))
      .catch(err => console.log(err));
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
    if (vendor.length === 0) {
      fetch(`${process.env.REACT_APP_BACKEND_URL}/vendors`)
        .then(res => res.json())
        .then(body => setVendor(body))
        .catch(err => console.log(err));
    }

    if (foods.length === 0) {
      fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`)
        .then(res => res.json())
        .then(body => setFoods(body))
        .catch(err => console.log(err));
    }
  }, [vendor, foods]);

  function handleAddFood() {
    if (!newFoodName || !newFoodType || !newFoodDesc || !selectedVendor) {
      console.log('Please fill in all the required fields.');
      return;
    }
  
    fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({
        foodID: setFoodID,
        foodName: newFoodName,
        foodType: newFoodType,
        foodDesc: newFoodDesc,
        vendorID: setVendor,
      }),
    })
      .then(res => {
        if (res.ok) {
          return res.json();
        } else {
          throw new Error('Failed to add food');
        }
      })
     
      .then(body => {
        setFoods([...foods, body]);
        console.log('Response Data:', body);
        setFoodID('');
        setNewFoodName('');
        setNewFoodType('');
        setNewFoodDesc('');
        setVendor('');
      })
     .catch(err => console.log(err));
  }
  

  return (
    <Flex>
      <Box paddingLeft={100} paddingTop={100}>
        <Heading> Add Food Item </Heading>
        <Box marginTop={4} >
        {/* <input
            type="text"
            placeholder="Food ID "
            value={foodID}
            onChange={e => setFoodID(e.target.value)}
          /> */}
          
          
          <br></br>
          <br></br>
          <input
            type="text"
            placeholder="Food Name"
            value={newFoodName}
            onChange={e => setNewFoodName(e.target.value)}
          />
          <br></br>
          <br></br>
          <input
            type="text"
            placeholder="Food Type"
            value={newFoodType}
            onChange={e => setNewFoodType(e.target.value)}
          />
          <br></br>
          <br></br>
          <input
            type="text"
            placeholder="Food Description"
            value={newFoodDesc}
            onChange={e => setNewFoodDesc(e.target.value)}
          />
          <br></br>
          <br></br>
          <input
            type="text"
            placeholder="Vendor ID"
            value={selectedVendor}
            onChange={e => setSelectedVendor(e.target.value)}
          />
          <br></br>
          <br></br>
          <Button w={'60%'} onClick={handleAddFood} colorScheme={'green'}>
            Add Food Item
          </Button>
        </Box>
      </Box>
    </Flex>
  );
};
