

function paddingLeft(padding: number | string, input: string): string {
    throw new Error("Not implement yet!");
};

function padLeft(padding: number | string, input: string) {

    if (typeof padding === "number") {
        return " ".repeat(padding) + input;
    }
    else {
        return padding + input;
    }
}

