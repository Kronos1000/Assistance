import {
  Card,
  CardHeader,
  CardBody,
  Heading,
  CardFooter,
  Button,
} from '@chakra-ui/react';
import React from 'react';

export const FoodItem = ({ foodId, name, description, listItems, setListItems }) => {
  const handleDelete = () => {
    fetch(`${process.env.REACT_APP_BACKEND_URL}/api/foods/delete/${foodId}`, {
      method: 'DELETE',
      headers: {
        Authorization: `Bearer ${sessionStorage.getItem('token')}`,
      },
    })
      .then((res) => res.json())
      .then((success) => {
        console.log(success);
        if (success) {
          const newItems = listItems.filter((item) => item.foodId !== foodId);
          setListItems([...newItems]);
        }
      })
      .catch((error) => {
        console.error('Error:', error);
      });
  };

  return (
    <Card>
      <CardHeader>
        <Heading size="md">{name}</Heading>
      </CardHeader>

      <CardBody>{description}</CardBody>
      <CardFooter>
        <Button variant="outline" colorScheme="red" onClick={handleDelete}>
          Delete
        </Button>
      </CardFooter>
    </Card>
  );
};
