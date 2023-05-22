let myButton = document.querySelector("button");
let myHeading = document.querySelector("h1");
let pikaButton = document.getElementById("pikaButton");
let pikaImg = document.getElementById("pikaImg");
let pikaImgScaleX = 1;

myButton.onclick = () => {
    setUserName();
}

pikaButton.onclick = () => {
    pikaImgScaleX = -pikaImgScaleX;
    pikaImg.style.transform = `scaleX(${pikaImgScaleX})`;
}

if (!localStorage.getItem("name")) {
    setUserName();
} else {
    const storedName = localStorage.getItem("name");
    myHeading.innerHTML = `Finally, an employee who <em>won't</em> ruin your business, ${storedName}`;
}

function setUserName(name) {
    const myName = prompt("Please enter your name.")
    localStorage.setItem("name", myName);
    myHeading.innerHTML = `Finally, an employee who <em>won't</em> ruin your business, ${myName}`;
}

let functionTest = document.getElementById("functionTest")
let scaleX = 1;
let scaleY = 1;
let angle = 0;

function multiply(num1, num2) {
    return num1 * num2;
}

function squashAndStretch() {
    scaleX = 1 + Math.sin(angle) * 0.08; // Adjust the amplitude as needed
    scaleY = 1 - Math.cos(angle) * 0.03;

    functionTest.style.transform = `scale(${scaleX}, ${scaleY})`;

    angle += 0.07; // Adjust the speed as needed

    // Call animate() on the next frame
    requestAnimationFrame(squashAndStretch);
    functionTest.textContent = "scaleX * scaleY " + multiply(scaleX, scaleY).toFixed(2);
}

// Start the animation loop
squashAndStretch();