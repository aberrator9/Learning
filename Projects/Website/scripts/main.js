const myHeading = document.getElementById("functionTest")



let scaleX = 1;
let scaleY = 1;
let angle = 0;

function multiply(num1, num2) {
    return num1 * num2;
}


function pressStartAnimation() {
    scaleX = 1 + Math.sin(angle) * 0.08; // Adjust the amplitude as needed
    scaleY = 1 - Math.cos(angle) * 0.03;

    myHeading.style.transform = `scale(${scaleX}, ${scaleY})`;

    angle += 0.07; // Adjust the speed as needed

    // Call animate() on the next frame
    requestAnimationFrame(pressStartAnimation);
    myHeading.textContent = "scaleX * scaleY " + multiply(scaleX, scaleY);
}

// Start the animation loop
pressStartAnimation();