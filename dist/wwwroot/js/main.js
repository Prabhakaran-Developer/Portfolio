document.addEventListener("DOMContentLoaded", () => {
    // IntersectionObserver setup
    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('visible');
                const targetId = entry.target.id;
                document.querySelectorAll('.section-btn').forEach(btn => {
                    btn.classList.remove('active');
                    if (btn.getAttribute('data-target') === targetId) {
                        btn.classList.add('active');
                    }
                });
            }
        });
    }, { threshold: 0.5 });

    // Observe all sections
    const allSections = document.querySelectorAll('.section, .intro-section');
    allSections.forEach(section => observer.observe(section));

    // Smooth scroll with offset
    document.querySelectorAll('.section-btn').forEach(button => {
        button.addEventListener('click', () => {
            const targetId = button.getAttribute('data-target');

            if (targetId === "Contact Me") {
                sessionStorage.setItem("redirectToSection", "about");
                window.location.href = '/Contact/Index';
                return;
            }

            const isOnHomePage = window.location.pathname.toLowerCase().includes('/home/index');

            if (!isOnHomePage) {
                // Redirect to Home and remember which section to scroll to
                sessionStorage.setItem("redirectToSection", targetId);
                window.location.href = '/Home/Index';
                return;
            }

            // Already on Home page — scroll to section
            const targetSection = document.getElementById(targetId);
            if (targetSection) {
                const topOffset = 80;
                const elementPosition = targetSection.getBoundingClientRect().top + window.pageYOffset;
                const offsetPosition = elementPosition - topOffset;

                window.scrollTo({
                    top: offsetPosition,
                    behavior: 'smooth'
                });
            }
        });
    });
});
