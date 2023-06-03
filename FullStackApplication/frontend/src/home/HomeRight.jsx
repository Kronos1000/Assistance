import React, { useEffect, useState } from 'react';
import { Box, Button, Flex, Heading, Text } from '@chakra-ui/react';

export const HomeRight = () => {
    const [selectedVendor, setSelectedVendor] = useState(1);
    const [vendor, setVendor] = useState([]);
    const [vehicles, setVehicles] = useState([]);

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
                .then(body => setVehicles(body))
                .catch(err => console.log(err));
        }
    }, []);

    function handleButtonClick(vendorID) {
        setSelectedVendor(vendorID);
        fetch(`${process.env.REACT_APP_BACKEND_URL}/vehicles`)
            .then(res => res.json())
            .then(body => setVehicles(body))
            .catch(err => console.log(err));
    }

    return (
        <Box width="33.33%" height="100vh"  p={4} >
           <a href="/Dashboard">

<Button 

              as="a"
              maxW={'55%'}
              aria-label="Home"
              my={5}
              w="15"
              colorScheme={'green'}
              
            
            >
      Dashboard
        <br></br>
            </Button>
         
           </a>
           
            <Flex flexDirection="column" justifyContent="flex-start" paddingTop={50} >
                <Heading size="md">Vehicles</Heading>

                {vehicles.map(v => {
                    if (v.vendorID === selectedVendor) {
                        return (
                            <Flex key={v.vehicleID} alignItems="center">
                                <Text>Vehicle Model: {v.vehicleName}</Text>
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
