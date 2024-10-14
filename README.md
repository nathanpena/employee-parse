
# Custom CSV Data Mapping Solution

This project demonstrates my ability as a data analyst to build custom data mapping solutions tailored for specific needs. The program reads a CSV file containing employee data, processes it by removing headers, mapping the data into a predefined format, and writing the output to a new file. This example showcases my ability to clean, transform, and standardize data for reporting and analysis.

## Overview

This project was developed to handle employee data efficiently by reading raw CSV data, extracting relevant fields, and formatting it according to business requirements. By mapping and transforming the data, I ensure accuracy and consistency across datasets, which is critical for both analysis and operational decision-making.

The solution can be easily adapted to other custom mapping tasks, demonstrating my proficiency in handling a wide variety of data processing requirements.

## Features

- **CSV Data Processing**: Reads and processes CSV data, removing unnecessary headers and formatting rows into a specific structure.
- **Custom Mapping**: Parses and transforms fields like full name, gender, SSN, and date of birth into a standardized format.
- **Department Mapping**: Automatically assigns a department based on the data provided, ensuring consistency.
- **Data Output**: Outputs the processed data into a pipe-delimited file, ensuring easy integration with other systems or workflows.

## How It Works

1. The program reads employee data from a CSV file.
2. It removes the headers from the raw data.
3. For each line, it processes the data by:
   - Parsing full names into first, middle, and last names.
   - Formatting gender, social security numbers (SSNs), and dates of birth.
   - Assigning a department based on the raw input.
4. Finally, the formatted data is written to a new pipe-delimited file for further use.

## Usage

### Prerequisites

- .NET environment setup
- A basic understanding of CSV files and data transformation

### Running the Program

To run the program:

1. Place your source CSV file (e.g., `MHSourceFile.csv`) in the specified directory.
2. Run the program to process the CSV and generate a new pipe-delimited file in the output directory.

### Example Input

```csv
"John Doe", M, "123-45-6789", "01/15/1980", "Corporate", "Software Engineer"
"Jane Smith", F, "987-65-4321", "05/22/1975", "Operations", "Project Manager"
```

### Example Output

```psv
John||Doe|M|123456789|1980-01-15|Corporate|Software Engineer
Jane||Smith|F|987654321|1975-05-22|Operations|Project Manager
```

## Contact

For any questions or collaboration inquiries, feel free to reach out via [LinkedIn](https://www.linkedin.com/in/nathan-pena-995a7155/).
