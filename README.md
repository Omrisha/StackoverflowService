# StackoverflowService

Simple REST API service for querying the best answers and question from our favorite site StackOverflow.

The service is built with .NET Core 3.1 and C#.

## Installation

- Run the command `git clone https://github.com/Omrisha/StackoverflowService.git`
- Open the SLN file in Visual Studio/Rider/Visual Studio Code
- Run the project (or  `dotnet run` if in VSCode).  

## Usage

- GET /stackoverflow/getbestquestions
 Get top 5 best questions from stackoverflow.
 
- GET /stackoverflow/getbestanswers/{questionId}
 Get top 5 answers from stackoverflow by qeustion Id.

- GET /stackoverflow/getowner/{answerId}
  Get the owner of the answer by answer Id.
