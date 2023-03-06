import 'bootstrap/dist/css/bootstrap.css';
import './App.css';

import { Row, Col, Input, Button } from 'reactstrap';
import { useState } from 'react';
import axios from 'axios';

axios.defaults.baseURL = process.env.REACT_APP_API_URL;

interface IBook {
  title?: string
  firstName?: string
  lastName?: string
  totalCopies?: number
  copiesInUse?: number
  type?: string
  isbn?: string
  category?: string
}

const App = () => {

  const [searchValue, setSearchValue] = useState('');
  const [searchByType, setSearchByType] = useState('');
  const [isLoading, setIsLoading] = useState(false);
  const [books, setBooks] = useState<IBook[]>([]);

  const handleSearch = async () => {

    setIsLoading(true);

    const result = await axios.get(
      `/books/search?searchValue=${searchValue}&searchType=${searchByType}`,
    );

    setBooks(result.data);

    setIsLoading(false);

  }

  return (
    <div className='mt-4 container'>
      <div className="form-search">
          <Row className="mt-4">
            <Col sm={4}>
              <label className=''>Search By:</label>
              <select onChange={(e) => {
                setSearchByType(e.target.value)
              }} className="form-select" aria-label="Default select example">
                <option selected>Select</option>
                <option value="Title">Title</option>
                <option value="Author">Author</option>
                <option value="Type">Type</option>
                <option value="ISBN">ISBN</option>
                <option value="Category">Category</option>
              </select>
            </Col>  
          </Row>
          <Row className="mt-4">
            <Col sm={4}>
              <label className=''>Search Value:</label>
              <Input
                autoComplete="none"
                className={'input-class'}
                value={searchValue}
                onChange={(e) => {
                  setSearchValue(e.target.value)
                }}
              >
              </Input>
            </Col>  
          </Row>
          <Row className="mt-2 justify-content-left">
            <Col sm={4}>
              <Button
                className="mt-4"
                onClick={handleSearch}
                disabled={isLoading}
              >
                Search
              </Button>
            </Col>
          </Row>
      </div>
      {books.length > 0 && 
      <div className="mt-4 form-search">
        <h5>Search results</h5>
        <table className="table">
          <thead>
            <tr>
              <th scope="col">Book Title</th>
              <th scope="col">Authors</th>
              <th scope="col">Type</th>
              <th scope="col">ISBN</th>
              <th scope="col">Category</th>
              <th scope="col">Available Copies</th>
            </tr>
          </thead>
          <tbody className="table-group-divider">
          {books?.map((book: IBook, index: number) => {
              return (
                <tr key={index}>
                  <td>
                    {book.title}
                  </td>
                  <td>{book.firstName} {book.lastName}</td>
                  <td>
                    {book.type}
                  </td>
                  <td>
                    {book.isbn}
                  </td>
                  <td>
                    {book.category}
                  </td>
                  <td>
                    {book.copiesInUse}/{book.totalCopies}
                  </td>
                </tr>
              );
            })}
          </tbody>
        </table>
      </div>}
    </div>
  );
}

export default App;
