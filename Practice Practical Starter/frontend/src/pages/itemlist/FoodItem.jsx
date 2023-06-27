import {
  Card,
  CardHeader,
  CardBody,
  Heading,
  CardFooter,
  Button,
} from '@chakra-ui/react';
import React from 'react';

export const FoodItem = ({foodId,name,description,listItems,setListItems}) => {
  
  const handleDelete = () => {
   fetch(`${process.env.REACT_APP_BACKEND_URL}/api/foods/delete/${foodId}`,
   {
   method: 'delete'
  })
  .then(res => res.json())
  .then(sucess => console.log(sucess)
    // if(sucess) { 
    //   const newItems=listItems.filter(item => item.foodId != foodId)
    //   setListItems([...newItems])
    // }
  //}
  )


  };
  return (
    <Card>
      <CardHeader>
        <Heading size="md">
     {name}
        </Heading>
      </CardHeader>

      <CardBody>
     {description}
      </CardBody>
      <CardFooter>
        <Button variant={'outline'} colorScheme="red">
          Delete
        </Button>
      </CardFooter>
    </Card>
  );
};
