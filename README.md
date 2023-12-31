# SQL Data Extractor

[![Build](https://github.com/B3zaleel/sql-data-extractor/actions/workflows/build.yaml/badge.svg)](https://github.com/B3zaleel/sql-data-extractor/actions/workflows/build.yaml)

SQLDataExtractor is a .NET CLI tool that provides functionality for extracting data from SQL databases.

## Features

- **Schema Extraction**: Extracts the types, functions, tables, indexes, and constraints from a database whilst keeping the correct dependency chain.
- **Row Extraction**: Extracts rows from a table whilst maintaining referential integrity.

### Supported Databases

|            | Schema Extraction | Row Extraction |
| :--------- | :---------------: | :------------: |
| MySQL      |        :x:        |      :x:       |
| PostgreSQL |        :white_check_mark:        |      :white_check_mark:       |

## Getting Started

### Installation

Install the [dotnet](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) CLI tool and run the following command.

``` powershell
dotnet tool install SqlDataExtractor
```

### Usage

Make sure to add the dotnet tools folder to your system/shell's **PATH**. Some example commands are shown below:

``` powershell
# Extract 5 rows from the `users` table
sde extract-rows --connection "$DbConnection" --schema "$DbSchema" --table users --limit 5

# Extract a database schema
sde extract-schema --connection "$DbConnection" --schema "$DbSchema"
```

## Contributing

We welcome contributions to SqlDataExtractor!

To get started contributing, you could raise an issue and provide enough details for us to investigate the issue.

You could also make changes to the project by forking the repository, creating a branch with the proposed changes, and opening a pull request in this repository.

You are always welcome to [buy me coffee](https://bmc.link/bezaleel) to keep me going.
