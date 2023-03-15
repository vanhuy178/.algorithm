function multiplyAll(values, factor) {
    if (!values) {
        return values;
    }
    else {
        return values.map(function (x) { return x * factor; });
    }
}
