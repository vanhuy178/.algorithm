
// truliness narrowing with !
// function multiplyAll(
//     values: number[] | undefined,
//     factor: number
// ): number[] | undefined {
//     if (!values) {
//         return values;
//     } else {
//         return values.map((x) => x * factor);
//     }
// }
function padLeft(padding: number | string, input: string) {
    if (typeof padding === 'number') {
        return " ".repeat(padding) + input;
    }
    return padding + input;
}

function example {
    let x: string | number | boolean;

    x = Math.random() < .5;

    console.log(x);

    if (Math.random() < .5) {
        x = "zoro";

    }

    else {
        x = 100;
    }

}