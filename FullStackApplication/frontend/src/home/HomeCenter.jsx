import React, { useEffect, useState } from 'react';
import { Box, Button, Flex, Heading, Text } from '@chakra-ui/react';

export const HomeCenter = () => {
    const [selectedVendor, setSelectedVendor] = useState(1);
    const [vendor, setVendor] = useState([]);
    const [furnitures, setFurnitures] = useState([]);

    useEffect(() => {
        if (vendor.length === 0) {
            fetch(`${process.env.REACT_APP_BACKEND_URL}/vendors`)
                .then(res => res.json())
                .then(body => setVendor(body))
                .catch(err => console.log(err));
        }

        if (furnitures.length === 0) {
            fetch(`${process.env.REACT_APP_BACKEND_URL}/furnitures`)
                .then(res => res.json())
                .then(body => setFurnitures(body))
                .catch(err => console.log(err));
        }
    }, []);

    function handleButtonClick(vendorID) {
        setSelectedVendor(vendorID);
        fetch(`${process.env.REACT_APP_BACKEND_URL}/furnitures`)
            .then(res => res.json())
            .then(body => setFurnitures(body))
            .catch(err => console.log(err));
    }

    return (
        <Box width="33.33%" height="100vh"  p={4} >
             <Heading> The Wondoruous Emporium</Heading>
           
            <Flex flexDirection="column" justifyContent="flex-start" paddingTop={50} >
              
                <Heading size="md">Furniture</Heading>

                {furnitures.map(f => {
                    if (f.vendorID === selectedVendor) {
                        return (
                            <Flex key={f.furnitureID} alignItems="center">
                                <Text>Furniture Name: {f.furnitureName}</Text>
                            </Flex>
                        );
                    }
                })}

                <Text>Sort Items By Vendor:</Text>
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
            </Flex>
        </Box>
    );
};
