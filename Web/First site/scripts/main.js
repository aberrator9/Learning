let myButton = document.querySelector("button");
let myHeading = document.querySelector("h1");
let pikaButton = document.getElementById("pikaButton");
let pikaImg = document.getElementById("pikaImg");
let pikaImgScaleX = 1;
let toTopButton = document.getElementById("to-top-button");

myButton.onclick = () => {
    setUserName();
}

pikaButton.onclick = () => {
    pikaImgScaleX = -pikaImgScaleX;
    pikaImg.style.transform = `scaleX(${pikaImgScaleX})`;
}

toTopButton.onclick = () => {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

window.onscroll = () => {
    showButton();
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

function showButton() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        toTopButton.style.display = "block";
    } else {
        toTopButton.style.display = "none";
    }

}

let squashAndStretchText = document.getElementById("squash-and-stretch")
let scaleX = 1;
let scaleY = 1;
let angle = 0;

function multiply(num1, num2) {
    return num1 * num2;
}


function squashAndStretch() {
    scaleX = 1 + Math.sin(angle) * 0.08; // Adjust the amplitude as needed
    scaleY = 1 - Math.cos(angle) * 0.03;

    squashAndStretchText.style.transform = `scale(${scaleX}, ${scaleY})`;

    angle += 0.07; // Adjust the speed as needed

    // Call animate() on the next frame
    requestAnimationFrame(squashAndStretch);
    squashAndStretchText.textContent = "scaleX * scaleY " + multiply(scaleX, scaleY).toFixed(2);
}

// Start the animation loop
squashAndStretch();
