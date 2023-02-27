

// apply, call, this
var person = {
    name: "James Smith",
    hello: function (thing) {
        console.log(this.name + " says hello " + thing);
    }
}

console.log(person.name);
person.hello.call({ name: 'Huy' }, 'I love you');