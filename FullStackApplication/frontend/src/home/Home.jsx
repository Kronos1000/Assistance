import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import React, { useEffect, useState } from 'react';
import { HomeCenter } from './HomeCenter';
import { HomeLeft } from './HomeLeft';
import { HomeRight } from './HomeRight';

export const Home = () => {


  const [furniture, setFurniture] = useState([]);
  const [vehicles, setVehicles] = useState([]);
  const [filteredFurniture, setFilteredFurniture] = useState([]);
  const [filteredVehicles, setFilteredVehicles] = useState([]);


  

  return (
    <Flex>
        
      <HomeLeft />
      <HomeCenter />
      <HomeRight />

    </Flex>
  );
}