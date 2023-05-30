
import React, { useState, } from 'react';

import cars from '../data/cars.json';
import { Box, Flex, Heading,SimpleGrid,Button,FormLabel,FormControl,Input,Textarea } from '@chakra-ui/react';

import { CarSection } from './CarSection';
import { StoreSection } from '../componennts/StoreSection';
export const Store = () => {


   

    let newCars = currentCars.map(car => {
      if (car.type === type) {
        if (car.quantity === 0) {
            hasCars = false;
            
          return car;
          }
         
          car.quantity--
       
        

          return car;
        
      }
      return car;
    });
    setCurrentCars(newCars);

    if (hasCars) {
      if (cart.map(item => item.type).includes(type)) {
        let newCart = cart.map(item => {
          if (item.type === type) {
              item.quantity++
             
              

              
              
            return item;
          }
          return item;
        });
        setCart(newCart);
      } else {
        let newItem = Object.assign({}, newCars.filter(car => car.type === type)[0]);
        newItem.quantity = 1;
        cart.push(newItem);
        setCart(cart);

 data = JSON.stringify(cart);





console.log(data);



   
      }
    }
  };

  const [searchString, setSearchString] = useState('');
  const [currentCars, setCurrentCars] = useState(cars);
  const [cart, setCart] = useState([]);
  const [name, setName] = useState('')
  const [email, setEmail] = useState('')
  const [deliveryAddress, setDeliveryAddress] = useState('')
   
var  data = JSON.stringify(cart);
  return (
    <Box>
      <Flex justifyContent={'center'} py={5}>
       
          </Flex>
      <Flex>
        <SimpleGrid w={'50%'} columns={1}>
          {currentCars
            .filter(car => car.type.includes(searchString))
            .map(car => (
              <CarSection
                key={car.id}
                quantity={car.quantity}
                type={car.type}
                addToCart={addToCart}
              />
            ))}
        </SimpleGrid>
        <Flex direction={'column'} alignItems={'center'} w={'50%'}>
          <Heading>Cart</Heading>
          <Flex direction={'column'}>

          <FormControl w={'100%' } >
              
              <FormLabel  >Your Name</FormLabel>
              <Input isRequired
              type="string"
                          value={name}
                          width={'100%' }
              onChange={n => setName(n.target.value)}
               placeholder="Your Name" />
            </FormControl>


            <FormControl  >
              <FormLabel>Email Address</FormLabel>
              <Input  isRequired
                          type="email"
                          width={'100%'}
            placeholder="Your Email Address"
            value={email}
            onChange={e => setEmail(e.target.value)}
          />

</FormControl>




            <FormControl >
              <FormLabel> Delivery Address </FormLabel>
              <Textarea  isRequired
              type="string" 
                          width={'100%'}
            maxLength={1000}
              value={deliveryAddress}
              onChange={da => setDeliveryAddress(da.target.value)}
              placeholder="Delivery Address" />
                 
            </FormControl>
            
            {cart.map(item => (
              <Box key={`${item.type}`}>
                {item.type.charAt(0).toUpperCase() + item.type.slice(1)} x {item.quantity}

                   

                </Box>
               
                
            ))}
            <a href='/store' >
                          <Button
                           width={'full'}> Clear Shopping Cart</Button>
                          </a>
                   <br></br>
               
                          <Button
                          
                          onClick={PurchaseMethod}
                          colorScheme={"green"}
                          > Checkout </Button>
                          
                          
                  
          </Flex>
        </Flex>
      </Flex>
      </Box>
     
  );

