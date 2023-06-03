import React from 'react'
import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import { useEffect, useState } from 'react';

export const LeftPanel = () => {
    const [selectedVendor, setSelectedVendor] = useState(1);
    const [vendor, setVendor] = useState([]);
    const [foods, setFoods] = useState([]);
    const [newFoodName, setNewFoodName] = useState('');
    const [newFoodType, setNewFoodType] = useState('');
    const[newFoodDesc, setNewFoodDesc] = useState('');
    const[newVendorID,setNewVendorID] = useState('');
    const[newFoodID,setNewFoodID] = useState('');
    function handleButtonClick(vendorID) {
        setSelectedVendor(vendorID);
        fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`)
            .then(res => res.json())
            .then(body => setFoods(body))
            .catch(err => console.log(err));
    }
function addData(){ 
    window.location.href = "./addfoods.html";
}
    function handleDeleteFood(foodID) {
        fetch(`${process.env.REACT_APP_BACKEND_URL}/foods/${foodID}`, {
            method: 'DELETE'
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
    
    function handleAddFood(event) {
        event.preventDefault(); // Prevent form submission
      
        const form = document.getElementById('myForm');
        const formData = new FormData(form);
        const formDataObject = Object.fromEntries(formData.entries());
      
        fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`, {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify(formDataObject),
        })
          .then(res => res.json())
          .then(body => {
            // Handle the response from the API
            console.log(body); // You can modify this based on your needs
            
            // Reset the form fields
            form.reset();
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
    }, []);

    return (
        <Flex>
            <Box paddingLeft={100} >
             
                <br />
                <br />
                <br />
                <br />
                <br />
                <Heading size={'md'}> Food  </Heading>

                {foods.map(f => {
                    if (f.vendorID === selectedVendor) {
                        return (
                            <Flex key={f.foodID} alignItems="center">
                                <Text>Food Name: {f.foodName}</Text>
                                {/* <Button
                                    ml={4}
                                    colorScheme="red"
                                    size="sm"
                                    onClick={() => handleDeleteFood(f.foodID)}
                                >
                                    Delete
                                </Button> */}
                            </Flex>
                        )
                    }
                })}

                <br />
                <br />
             



                <Text> Sort Items By Vendor:</Text>
                {vendor.map(v => (
                    <div key={v.vendorID}>
                        <Button
                            colorScheme={selectedVendor === v.vendorID ? 'green' : 'blue'}
                            onClick={() => handleButtonClick(v.vendorID)}
                        >
                            {v.name}
                        </Button>
                        <br />
                    </div>
                ))}


            </Box>
      
        </Flex>
    )
}