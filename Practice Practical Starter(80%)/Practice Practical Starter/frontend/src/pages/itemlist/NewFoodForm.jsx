import {
  Button,
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalCloseButton,
  ModalBody,
  ModalFooter,
  Input,
} from '@chakra-ui/react';
import React, { useRef } from 'react';

export const NewFoodForm = ({ isOpen, onClose }) => {
  const SubmitFormHandler = () => {
    const name = foodName.current.value;
    const description = foodDescription.current.value;
    const NewFoodRequest = {
      "name": name,
      "description": description,
      "restaurantId": 1
    }
    fetch(`${process.env.REACT_APP_BACKEND_URL}/api/foods/create`, {
      method: 'post',
      body: JSON.stringify(NewFoodRequest),
      headers: { 
        "Content-Type": 'application/json',
        Authorization: `Bearer ${sessionStorage.getItem('token')}`,
      }
    }); // <-- Added closing parenthesis here
    
    // TODO: Implement the logic to make an HTTP request to create a new item in the backend.
    // TODO: The data will need to be sent from the form that is created below.
    // TODO: You can use either useState or useRef hooks to get the data from the form into the request.
  };

  const foodName = useRef("");
  const foodDescription = useRef("");

  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <ModalOverlay />
      <ModalContent>
        <ModalHeader>Create New Food</ModalHeader>
        <ModalCloseButton />
        <ModalBody>
          <Input ref={foodName} placeholder="Food name" />
          <Input ref={foodDescription} placeholder="foodDescription" />
        </ModalBody>

        <ModalFooter>
          <Button
            colorScheme="gray"
            variant={'outline'}
            mr={3}
            onClick={onClose}
          >
            Close
          </Button>
          <Button onClick={SubmitFormHandler} variant="outline" colorScheme="green">
            Create
          </Button>
        </ModalFooter>
      </ModalContent>
    </Modal>
  );
};
