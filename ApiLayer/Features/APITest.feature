Feature: API Testing

  Background:
    Given the API base URL is "https://petstore.swagger.io/v2"

  Scenario: Testing GET method for the API
    When I send a GET request to "/pet"
    Then the response status code should be 200

  Scenario: Testing POST method for the API
    Given the request body is
      """
      {
        "id": 0,
        "category": {
          "id": 0,
          "name": "string"
        },
        "name": "doggie",
        "photoUrls": [
          "string"
        ],
        "tags": [
          {
            "id": 0,
            "name": "string"
          }
        ],
        "status": "available"
      }
      """
    When I send a POST request to "/pet"
    Then the response status code should be 200

  Scenario: Testing PUT method for the API
    Given the request body is
      """
      {
        "id": 0,
        "category": {
          "id": 0,
          "name": "string"
        },
        "name": "doggie",
        "photoUrls": [
          "string"
        ],
        "tags": [
          {
            "id": 0,
            "name": "string"
          }
        ],
        "status": "available"
      }
      """
    When I send a PUT request to "/pet"
    Then the response status code should be 200

  Scenario: Testing DELETE method for the API
    When I send a DELETE request to "/pet/0"
    Then the response status code should be 200
