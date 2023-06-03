import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import React, { useEffect, useState } from 'react';
import { CenterPanel } from './CenterPanel';
import { LeftPanel } from './LeftPanel';
import { RightPanel } from './RightPanel';

export const Home = () => {


  const [furniture, setFurniture] = useState([]);
  const [vehicles, setVehicles] = useState([]);
  const [filteredFurniture, setFilteredFurniture] = useState([]);
  const [filteredVehicles, setFilteredVehicles] = useState([]);


  

  return (
    <Flex>
    <Box >
   
           
      <LeftPanel />

       </Box>
      <a href='./dashboard'></a>

      <Box w={"50%"} >
      <Center>
            <Heading> The magical emporium </Heading>
       
           
          
            </Center>
              <Center> 
            <Text size={'LG'}> Inventory </Text>
            </Center>
      <CenterPanel />
</Box>


<Box w={"33%"} >
      <RightPanel />
</Box>


<a href='./Dashboard'>
  
    <Button> Dashboard</Button>
    </a> 
   
    </Flex>
  );
}