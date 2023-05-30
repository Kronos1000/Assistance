import React from 'react'
import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import { useEffect, useState } from 'react';




export const CenterPanel = () => {
    const [selectedVendor, setSelectedVendor] = useState(1);
    const [vendor, setVendor] = useState([]);
    const [ftype, setFtype] = useState([]);
    const [selectedFtype,setSelectedFtype] = useState(1);
    const [foods, setFoods] = useState([]);

    function handleButtonClick(vendorID) {
        setSelectedVendor(vendorID)
        fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`)
            .then(res => res.json())
            .then(body => setFoods(body)).catch(err => console.log(err));


    }
    console.log(foods);

    useEffect(() => {
        if (vendor.length === 0) {
            fetch(`${process.env.REACT_APP_BACKEND_URL}/vendors`)
                .then(res => res.json())
                .then(body => setVendor(body)).catch(err => console.log(err));
                

        }

        if (foods.length === 0) {
            fetch(`${process.env.REACT_APP_BACKEND_URL}/foods`)
                .then(res => res.json())
                .then(body => setFoods(body)).catch(err => console.log(err));


        }

    }, [])



    return (
        <Flex>
        <Box paddingLeft={100} >
     
            <br />
            <br />
            <Heading size={'md'}> ?? </Heading>
          
            {foods.map(f => {
                if (f.vendorID === selectedVendor) {
                    return (
                        <Text key={f.foodID}>

                            Food Name: {f.foodName}
                        </Text>


                    )
                }
            })

            }

<br></br> 
<br></br>
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
