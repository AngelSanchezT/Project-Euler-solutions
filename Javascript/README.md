# Project Euler solutions in JavaScript <!-- omit in toc -->

This directory contains solutions to Project Euler problems implemented in JavaScript. Each problem has its own solution in a separe file and unit tests are included for each of them.

## Table of Contents <!-- omit in toc -->
- [Structure of the repository](#structure-of-the-repository)
- [Execution of unit tests](#execution-of-unit-tests)

## Structure of the repository

The directory and file structure in this repository is as follows:

```
project-euler/
├── problems/
│ ├── problem1.js
│ ├── problem2.js
│ ├── ...
│ └── problemX.js
└── tests/
├── problem1.test.js
├── problem2.test.js
├── ...
└── problemX.test.js
```

The `problems/` directory contains the files with the solutions to Project Euler problems. Each problem has its own file, for example: `problem001.js`, `problem002.js`, etc.

The `tests/` directory contains the unit test files for each problem. Each test file corresponds to the solution of a problem, for example: `problem001.test.js`, `problem002.test.js`, etc.

## Execution of unit tests

To run the unit tests, make sure you have Node.js and npm installed on your system. The follow these steps:

1. Clone this repository to your local machine:

```bash
git clone https://github.com/AngelSanchezT/Project-Euler-solutions.git
```
2. Navigate to the repository directory:

```
cd Project-Euler-solutions/Javascript
``` 

3. Install the project dependencies:

```
npm install
```

4. Run the unit tests:

```
npx jest
```

The will run all the unit tests and display the results in the terminal,

If you want to run specific tests, you can use the additional commands provided by Jest. You can refer to the Jest documentation for more details on the available options.