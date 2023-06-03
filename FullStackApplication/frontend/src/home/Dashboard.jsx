import { Box, Button, Center, Flex, Heading, Spinner, Text } from '@chakra-ui/react';
import React, { useEffect, useState } from 'react';

import { DashboardLeft } from './DashboardLeft';
import { DashboardRight } from './DashboardRight';
import { DashboardCenter} from './DashboardCenter';


export const Dashboard = () => {


  const [furniture, setFurniture] = useState([]);
  const [vehicles, setVehicles] = useState([]);
  const [filteredFurniture, setFilteredFurniture] = useState([]);
  const [filteredVehicles, setFilteredVehicles] = useState([]);


  

  return (
    <Flex >
    
     <DashboardLeft />
      <DashboardCenter />
      <DashboardRight />

    

   
    </Flex>
  );
}