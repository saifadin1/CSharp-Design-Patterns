# Builder Pattern - Computer Builder

## Problem Description

You have been tasked with creating a system that allows users to build a custom Computer Configuration. The system should let users specify required components and optionally select additional features. The goal is to implement the Builder Pattern to manage object creation effectively.

## Problem Solution

The Builder Pattern is a creational design pattern that allows constructing complex objects step by step. 
1. Create a class `Computer` with properties for the required components like `memory`, `storage`, and `cpu`.
2. Create a `ComputerBuilder` class with methods to set the optional features like `graphicsCard`, `PowerSupply`, and `CoolingSystem`.
3. Add a methods for adding the optional components to the `ComputerBuilder` class while required components are set in the constructor.
4. Create a method `build` in the `ComputerBuilder` class that returns a `Computer` object with the specified configuration.