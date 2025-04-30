

// Disable right-click context menu
document.addEventListener('contextmenu', event => event.preventDefault());

document.addEventListener("keydown", function (event) {
    if (
        event.key === "F12" ||  // F12
        (event.ctrlKey && event.shiftKey && (event.key === "I" || event.key === "J" || event.key === "C" || event.key === "K" || event.key === "S")) || // Ctrl+Shift+I/J/C/K/S
        (event.ctrlKey && event.key === "U") ||  // Ctrl+U
        (event.metaKey && event.altKey && (event.key === "I" || event.key === "J" || event.key === "C"))  // Cmd+Option+I/J/C (Mac)
    ) {
        event.preventDefault();
    }
});

(function detectDevTools() {
    setInterval(() => {
        if (window.outerWidth - window.innerWidth > 160 || window.outerHeight - window.innerHeight > 160) {
            window.location.href = "about:blank"; 
        }
    }, 1000);
})();


