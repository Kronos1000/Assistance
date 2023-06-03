import React from 'react'
import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import { useEffect, useState } from 'react';

export const RightPanel = () => {
    const [selectedVendor, setSelectedVendor] = useState(1);
    const [vendor, setVendor] = useState([]);
    const [vehicles, setvehicles] = useState([]);

    function handleButtonClick(vendorID) {
        setSelectedVendor(vendorID);
        fetch(`${process.env.REACT_APP_BACKEND_URL}/vehicles`)
            .then(res => res.json())
            .then(body => setvehicles(body))
            .catch(err => console.log(err));
    }
function addData(){ 
    window.location.href = "./addvehicles.html";
}
    function handleDeleteFurniture(vehicleID) {
        fetch(`${process.env.REACT_APP_BACKEND_URL}/vehicles${vehicleID}`, {
            method: 'DELETE'
        })
            .then(res => {
                if (res.ok) {
                    setvehicles(vehicles.filter(f => f.vehicleID !== vehicleID));
                } else {
                    console.log('Failed to delete Furniture');
                }
            })
            .catch(err => console.log(err));
    }
    
    function handleAddFurniture(event) {
        event.preventDefault(); // Prevent form submission
      
        const form = document.getElementById('myForm');
        const formData = new FormData(form);
        const formDataObject = Object.fromEntries(formData.entries());
      
        fetch(`${process.env.REACT_APP_BACKEND_URL}/vehicles`, {
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

        if (vehicles.length === 0) {
            fetch(`${process.env.REACT_APP_BACKEND_URL}/vehicles`)
                .then(res => res.json())
                .then(body => setvehicles(body))
                .catch(err => console.log(err));
        }
    }, []);

    return (
        <Flex>
            <Box >
     
         
<br/>      
<br/>              
<br/>   
<br/>   
           
                <Heading size={'md'}> Vehicles </Heading>

                {vehicles.map(f => {
                    if (f.vendorID === selectedVendor) {
                        return (
                            <Flex key={f.vehicleID} alignItems="center">
                                <Text>Vehicle Model: {f.vehicleName}</Text>
                                {/* <Button
                                    ml={4}
                                    colorScheme="red"
                                    size="sm"
                                    onClick={() => handleDeleteFurniture(f.vehicleID)}
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