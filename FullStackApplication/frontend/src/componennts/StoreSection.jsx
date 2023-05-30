import { Button, Flex, Heading, Text } from '@chakra-ui/react';
import React from 'react';

export const StoreSection = ({ type, quantity, addToCart }) => {
  return (
      <Flex direction={'column'} alignItems={'Right'} p={10}>
          
      <Heading>{type}</Heading>
      <Text>Quantity Availiable: {quantity}</Text>
      <Button
        colorScheme="orange"
        onClick={() => {
          addToCart(type);
        }}
      >
        Add to Cart
          </Button>

          
    </Flex>
  );
};
