import React, {Component} from 'react';
import { Header, Icon } from 'semantic-ui-react'
import './App.css';
import axios from 'axios';
//import { Button } from 'semantic-ui-react'
import 'semantic-ui-css/semantic.min.css';

class App extends Component {
    state = { values: [] }

    componentDidMount() {
        axios.get('http://localhost:5000/api/values/')
        .then((response) => {
            //console.log(response);
            this.setState({
                values: response.data
            })
        })

        //this.setState({
        // values: [{ id: 1, name: 'Value 101' }, { id: 2, name: 'Value 102' } ]
        //})
    }

    render() {
        return (
            <div>
           
             <Header as='h2'>
             <Icon name='users' />
             <Header.Content>Users</Header.Content>
             </Header>
                    <ul>
                        {this.state.values.map((value: any) => (
                            <li key={value.id}>{value.name}</li>
                            ))}
                    </ul>
              
            </div>
        );
    }
}


export default App;