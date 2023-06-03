import React from 'react'
import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import { useEffect, useState } from 'react';

export const CenterPanel = () => {
    const [selectedVendor, setSelectedVendor] = useState(1);
    const [vendor, setVendor] = useState([]);
    const [furnitures, setFurnitures] = useState([]);

    function handleButtonClick(vendorID) {
        setSelectedVendor(vendorID);
        fetch(`${process.env.REACT_APP_BACKEND_URL}/furnitures`)
            .then(res => res.json())
            .then(body => setFurnitures(body))
            .catch(err => console.log(err));
    }
function addData(){ 
    window.location.href = "./addFurnitures.html";
}
    function handleDeleteFurniture(furnitureID) {
        fetch(`${process.env.REACT_APP_BACKEND_URL}/Furnitures${furnitureID}`, {
            method: 'DELETE'
        })
            .then(res => {
                if (res.ok) {
                    setFurnitures(furnitures.filter(f => f.furnitureID !== furnitureID));
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
      
        fetch(`${process.env.REACT_APP_BACKEND_URL}/Furnitures`, {
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

        if (furnitures.length === 0) {
            fetch(`${process.env.REACT_APP_BACKEND_URL}/Furnitures`)
                .then(res => res.json())
                .then(body => setFurnitures(body))
                .catch(err => console.log(err));
        }
    }, []);

    return (
        <Flex>
            <Box paddingLeft={100}>
<br/>
<br/>
<br/>
<br/>
          
           
                <Heading size={'md'}> Furniture </Heading>

                {furnitures.map(f => {
                    if (f.vendorID === selectedVendor) {
                        return (
                            <Flex key={f.furnitureID} alignItems="center">
                                <Text>Furniture Name: {f.furnitureName}</Text>
                                {/* <Button
                                    ml={4}
                                    colorScheme="red"
                                    size="sm"
                                    onClick={() => handleDeleteFurniture(f.furnitureID)}
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