import React from 'react'
import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import { useEffect, useState } from 'react';

export const LeftPanel = () => {
    const [selectedVendor, setSelectedVendor] = useState(1);
    const [vendor, setVendor] = useState([]);
    const [foods, setFoods] = useState([]);

    function handleButtonClick(vendorID) {
        setSelectedVendor(vendorID);
        fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`)
            .then(res => res.json())
            .then(body => setFoods(body))
            .catch(err => console.log(err));
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
            <Box paddingLeft={100}>
                <Center>
                    <Heading> The Random Store </Heading>
                </Center>
                <br />
                <br />
                <Heading size={'md'}> Food (Yummy) ?? </Heading>

                {foods.map(f => {
                    if (f.vendorID === selectedVendor) {
                        return (
                            <Flex key={f.foodID} alignItems="center">
                                <Text>Food Name: {f.foodName}</Text>
                                <Button
                                    ml={4}
                                    colorScheme="red"
                                    size="sm"
                                    onClick={() => handleDeleteFood(f.foodID)}
                                >
                                    Delete
                                </Button>
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