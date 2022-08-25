import School1 from "./school1";

function School2(){
    return(
        <div>
            <SchoolChild name="StClaretSchool" address="Nagpur"/>                
        </div>
    );
}
function SchoolChild(props){
    return(
        <div>
            <h1>My scholname is {this.state.name} and address is {this.state.address}</h1>
        </div>
    )
}
export default School1;