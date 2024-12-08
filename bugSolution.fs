let x = 10
let y = 20

let add x y = x + y

let z = add x y
printf "%d" z

// To update z, we need to recalculate it.
let x2 = 30
let y2 = 40
let z2 = add x2 y2
printf "%d %d %d" x2 y2 z2