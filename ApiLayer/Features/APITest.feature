Feature: API Testing

  Scenario: Test GET method for /pet endpoint
    Given the API endpoint is set to /pet
    When a GET request is sent
    Then the response status code should be 200

  Scenario: Test POST method for /pet endpoint
    Given the API endpoint is set to /pet
    And the request body is valid
    When a POST request is sent
    Then the response status code should be 200

  Scenario: Test PUT method for /pet endpoint
    Given the API endpoint is set to /pet
    And the request body contains updates
    When a PUT request is sent
    Then the response status code should be 200

  Scenario: Test DELETE method for /pet endpoint
    Given the API endpoint is set to /pet
    And a pet ID is provided
    When a DELETE request is sent
    Then the response status code should be 200