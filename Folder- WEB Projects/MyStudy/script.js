var listElement = document.querySelector('#todoList ul');
var inputElement = document.querySelector('#todoList todoInput');
var buttonElement = document.querySelector('#todoList todoButton');

var todos = [
    'Eat chocolate',
    'Study js',
    'Blabla'
];

function renderTodos() {
    listElement.innerHTML = '';

    for (todo of todos) {
        var todoElement = document.createElement('li');
        var todoText = document.createTextNode(todo);

        var linkElement = document.createElement('a');

        linkElement.setAttribute('href', '#');

        var pos = todos.indexOf(todo);
        linkElement.setAttribute('onclick', 'deleteTodo(' + pos + ')');

        var linkText = document.createTextNode('Delete');

        linkElement.appendChild(linkText);

        todoElement.appendChild(todoText);
        todoElement.appendChild(linkElement);
        listElement.appendChild(todoElement);
    }
}

renderTodos();

function addTodo() {
    var todoText = inputElement.Value;

    todos.push(todoText);
    console.log(todos);
    inputElement.Value = '';
    renderTodos();
}

buttonElement.onclick = addTodo();

function deleteTodo(pos) {
    todos.splice(pos, 1);//remove the first item after the pointed one (position/pos)
}









