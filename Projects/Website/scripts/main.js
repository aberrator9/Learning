const myHeading = document.querySelector("h1")
myHeading.textContent = "PRESS START";

// Set the initial scale values
let scaleX = 1;
let scaleY = 1;
let angle = 0;

// Start the animation
function animate() {
    // Calculate the scale values using a sine function
    scaleX = 1 + Math.sin(angle) * 0.1; // Adjust the amplitude as needed
    scaleY = 1 - Math.cos(angle) * 0.03;

    // Apply the scale values using CSS transform
    myHeading.style.transform = `scale(${scaleX}, ${scaleY})`;

    // Increase the angle for the next frame
    angle += 0.07; // Adjust the speed as needed

    // Call animate() on the next frame
    requestAnimationFrame(animate);
}

// Start the animation loop
animate();