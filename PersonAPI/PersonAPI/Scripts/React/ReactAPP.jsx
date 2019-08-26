
const api = "http://localhost:59230/api/"

class PersonList extends React.Component {
    constructor() {
        super();
        this.state = {
            PersonData: []
        }
    }

    getInfo = () => {
        
        axios.get(`${api}/person/`).then(response => {
             
            this.setState({
              
                PersonData: response.data
            });
        });
    }

    render() {
         this.getInfo()
        return (
            
            <form>
                <h1>Person List</h1>
                <input
                    type="text"
                    placeholder="Search for..."
                    ref={input => this.search = input}
                />
                
                <section>
                    <div>
                      
                            
                        <ol className='person-list'>
                            {
                                this.state.PersonData.filter(e => e.LastName.toLowerCase().includes(this.search.value.toLowerCase()) || e.FirstName.toLowerCase().includes(this.search.value.toLowerCase())).map((person, index) => {
                                    return <li key={person.personID} className='person-list-item'>
                                        <div><img className='person-avatar' src={person.PhotoPath} /></div>
                                        <div className='person-details'>

                                            <p>{person.FirstName ? person.FirstName : 'NA'}</p>
                                            <p>{person.LastName ? person.LastName : 'NA'}</p>
                                            <p>{person.Age ? person.Age : 'NA'}</p>
                                            <p>{person.Address ? person.Address : 'NA'}</p>
                                            <p>{person.City ? person.City : 'NA'}</p>
                                            <p>{person.PostalCode ? person.PostalCode : 'NA'}</p>
                                            <p>{person.Interests ? person.Interests : 'NA'}</p>

                                        </div>
                                    </li>;
                                })
                            }
                        </ol>

                          
                       
                 </div>
                   
               </section>
            </form>
        )
    }
}
ReactDOM.render(< PersonList />, document.getElementById('myContainer'));
