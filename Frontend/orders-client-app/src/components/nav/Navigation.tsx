import React from 'react';
import Nav from 'react-bootstrap/Nav';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Container, Navbar } from 'react-bootstrap';

export default function Navigation() {
    return (
        <Navbar bg="primary" data-bs-theme="dark">
        <Container>
          <Navbar.Brand href="/Home">Домашняя страница</Navbar.Brand>
          <Nav className="me-auto">
            <Nav.Link href="/Orders">Заказы</Nav.Link>
          </Nav>
        </Container>
      </Navbar>
    );
}