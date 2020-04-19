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

1. Run app with the following command:

```
dotnet run
```

2. start the app on:

```
http://localhost:5000/
https://localhost:5001/
```
 
## Diagrams 💎


## EnD Points 🔍

### Projects

```
GET PROJECTS
{Host}:{Port}/api/v1/projects
{Host}:{Port}/api/v1/projects/{project_id}
https://localhost:5001/api/projects
https://localhost:5001/api/projects/c903a85d

POST PROJECTS
{Host}:{Port}/api/v1/projects
https://localhost:5001/api/projects
BODY:
[
    {
        "name": "Proyecto Seguridad",
        "description": "Proyecto de Seguridad",
        "state": "Inactivo",
        "createdDate": "27-05-2019"
    }
]

PUT PROJECTS
{Host}:{Port}/api/v1/projects/{project_id}
localhost:8080/api/v1/projects/c903a85d
BODY:
{
   "name": "Proyecto Seguridad",
   "description": "Proyecto de Seguridad",
   "state": "Inactivo",
   "createdDate": "27-05-2019"
}

DELETE PROJECTS
{Host}:{Port}/api/v1/projects/{project_id}
https://localhost:5001/api/projects/c903a85d
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
