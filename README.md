# Projects

This projet is using dotnet version 2.1.700

this project was created with the following command:

```
dotnet new webapi
```

## Prerequisites 🚀

1. Install Windows 10 or Linux
2. Install dotnet version 2.1.700
3. Optional docker.

## Installation 🔨

1. Install windows or linux.
2. Download the dotnet from: https://dotnet.microsoft.com/download/dotnet-core/2.1

## Configuration 🔧


1. start the app on:

```
https://localhost:5001/api/values

```
 
## Diagrams 💎


## Usage 🔍

### USERS

```
GET USERS
{Host}:{Port}/api/v1/users
{Host}:{Port}/api/v1/users/{user_id}
localhost:8080/api/v1/users
localhost:8080/api/v1/users/5814525

POST USERS
{Host}:{Port}/api/v1/users
localhost:8080/api/v1/users
BODY:
{
    "id": "5814525",
    "password": "pass123",
    "name": "Sheldon",
    "lastName": "Cooper",
    "birthDate": "1994-05-26",
    "email": "Sheldon.Cooper@gmail.com",
    "type": "admin"
}

PUT USERS
{Host}:{Port}/api/v1/users/{user_id}
localhost:8080/api/v1/users/5814527
BODY:
{
    "id": "5814525",
    "password": "secret123",
    "name": "Sheldon",
    "lastName": "Cooper",
    "birthDate": "1994-05-26",
    "email": "Sheldon_Cooper@gmail.com",
    "type": "seller"
}

DELETE USERS
{Host}:{Port}/api/v1/users/{user_id}
localhost:8080/api/v1/users/5814527
```

### ITEMS

```
GET ITEMS
{Host}:{Port}/api/v1/items
{Host}:{Port}/api/v1/items/{item_id}
localhost:8080/api/v1/items
localhost:8080/api/v1/items/1001

POST ITEMS
{Host}:{Port}/api/v1/items
localhost:8080/api/v1/items
BODY:
{
    "name": "Drink RedBeer",
    "price": 35,
    "stock": 25
}

PUT ITEMS
{Host}:{Port}/api/v1/items/{item_id}
localhost:8080/api/v1/items/1001
BODY:
{
    "name": "Drink GreenBeer",
    "price": 25,
    "stock": 15
}

DELETE ITEMS
{Host}:{Port}/api/v1/items/{item_id}
localhost:8080/api/v1/items/1001
```

## Contributing 💡

1. Fork it!
2. Create your feature branch: `git checkout -b issue/1001`
3. Commit your changes: `git commit -m 'issue/1001: Add some feature'`
4. Push to the branch: `git push origin issue/1001`
5. Submit a pull request.

## MIT License 📃

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
