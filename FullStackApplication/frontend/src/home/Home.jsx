import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import React, { useEffect, useState } from 'react';
import { CenterPanel } from './CenterPanel';
import { LeftPanel } from './LeftPanel';

export const Home = () => {


  const [furniture, setFurniture] = useState([]);
  const [vehicles, setVehicles] = useState([]);
  const [filteredFurniture, setFilteredFurniture] = useState([]);
  const [filteredVehicles, setFilteredVehicles] = useState([]);


  

  return (
    <Flex>
    
      <LeftPanel />
      <CenterPanel />


   
    </Flex>
  );
}