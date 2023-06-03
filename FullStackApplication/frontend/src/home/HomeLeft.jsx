import React, { useEffect, useState } from 'react';
import { Box, Button, Flex, Heading, Text } from '@chakra-ui/react';

export const HomeLeft = () => {
    const [selectedVendor, setSelectedVendor] = useState(1);
    const [vendor, setVendor] = useState([]);
    const [foods, setFoods] = useState([]);

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
        <Box width="33.33%" height="100vh"  p={4} paddingTop={120}>
            <Flex flexDirection="column" justifyContent="flex-start" >
                <Heading size="md">Food</Heading>

                {foods.map(f => {
                    if (f.vendorID === selectedVendor) {
                        return (
                            <Flex key={f.foodID} alignItems="center">
                                <Text>Food Name: {f.foodName}</Text>
                            </Flex>
                        );
                    }
                })}

                <Text>Sort Items By Vendor:</Text>
                {vendor.map(v => (
                    <div key={v.vendorID}>
                        <Button
                            colorScheme={selectedVendor === v.vendorID ? 'green' : 'blue'}
                            onClick={() => setSelectedVendor(v.vendorID)}
                        >
                            {v.name}
                        </Button>
                        <br />
                    </div>
                ))}
            </Flex>
        </Box>
    );
};
