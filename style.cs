/* =========================
   GLOBAL
========================= */

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: Arial, Helvetica, sans-serif;
    color: #222;
    background: #fff;
    line-height: 1.7;
}

img {
    width: 100%;
    display: block;
}

a {
    text-decoration: none;
    color: inherit;
}

.container {
    width: min(1180px, 92%);
    margin: auto;
}

.section {
    padding: 90px 0;
}

:root {
    --primary: #087443;
    --primary-dark: #045b34;
    --secondary: #f5b400;
    --dark: #10231b;
    --light: #f6f9f7;
    --text: #555;
}


/* =========================
   TOPBAR
========================= */

.topbar {
    background: var(--dark);
    color: white;
    font-size: 14px;
}

.topbar-content {
    min-height: 40px;
    display: flex;
    align-items: center;
    justify-content: space-between;
}

.topbar i {
    color: var(--secondary);
    margin-right: 7px;
}


/* =========================
   NAVBAR
========================= */

.navbar {
    background: white;
    box-shadow: 0 2px 15px rgba(0,0,0,.08);
    position: sticky;
    top: 0;
    z-index: 999;
}

.nav-content {
    min-height: 85px;
    display: flex;
    align-items: center;
    justify-content: space-between;
}

.logo {
    display: flex;
    align-items: center;
    gap: 12px;
}

.logo img {
    width: 55px;
    height: 55px;
    object-fit: contain;
}

.logo strong {
    display: block;
    color: var(--primary);
    font-size: 23px;
}

.logo span {
    display: block;
    color: #777;
    font-size: 12px;
}

nav {
    display: flex;
    align-items: center;
    gap: 25px;
}

nav a {
    font-size: 14px;
    font-weight: 600;
    transition: .3s;
}

nav a:hover {
    color: var(--primary);
}

.nav-button {
    background: var(--primary);
    color: white !important;
    padding: 13px 20px;
    border-radius: 5px;
}

.nav-button:hover {
    background: var(--primary-dark);
}

.menu-toggle {
    display: none;
    border: none;
    background: none;
    font-size: 25px;
    color: var(--primary);
}


/* =========================
   HERO
========================= */

.hero {
    min-height: 650px;
    position: relative;
    background:
        url("assets/hero.jpg")
        center/cover no-repeat;
    display: flex;
    align-items: center;
}

.hero-overlay {
    position: absolute;
    inset: 0;
    background:
        linear-gradient(
            90deg,
            rgba(3,35,22,.9),
            rgba(3,35,22,.55),
            rgba(3,35,22,.1)
        );
}

.hero-content {
    position: relative;
    z-index: 2;
}

.hero-text {
    max-width: 700px;
    color: white;
}

.hero-small {
    color: var(--secondary);
    font-size: 14px;
    font-weight: bold;
    letter-spacing: 1px;
}

.hero h1 {
    font-size: clamp(42px, 6vw, 72px);
    line-height: 1.08;
    margin: 20px 0;
}

.hero h1 span {
    color: var(--secondary);
    display: block;
}

.hero p {
    font-size: 18px;
    max-width: 650px;
    color: #eee;
}

.hero-buttons {
    display: flex;
    gap: 15px;
    margin-top: 30px;
}

.btn {
    display: inline-block;
    padding: 14px 25px;
    border-radius: 5px;
    font-weight: bold;
    transition: .3s;
}

.btn-primary {
    background: var(--primary);
    color: white;
}

.btn-primary:hover {
    background: var(--primary-dark);
    transform: translateY(-2px);
}

.btn-outline {
    border: 2px solid white;
    color: white;
}

.btn-outline:hover {
    background: white;
    color: var(--primary);
}


/* =========================
   QUICK LINKS
========================= */

.quick-links {
    margin-top: -45px;
    position: relative;
    z-index: 5;
}

.quick-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    background: white;
    box-shadow: 0 10px 35px rgba(0,0,0,.12);
}

.quick-grid a {
    padding: 25px;
    display: flex;
    gap: 18px;
    align-items: center;
    border-right: 1px solid #eee;
}

.quick-grid i {
    width: 55px;
    height: 55px;
    background: #eaf6ef;
    color: var(--primary);
    display: grid;
    place-items: center;
    border-radius: 50%;
    font-size: 22px;
}

.quick-grid strong {
    display: block;
}

.quick-grid span {
    font-size: 13px;
    color: #777;
}


/* =========================
   SECTION HEADINGS
========================= */

.section-heading {
    max-width: 700px;
    text-align: center;
    margin: 0 auto 50px;
}

.section-label {
    color: var(--primary);
    font-weight: bold;
    font-size: 13px;
    letter-spacing: 2px;
}

.section-heading h2,
.about-content h2 {
    font-size: 42px;
    line-height: 1.2;
    margin: 12px 0 18px;
}

.section-heading h2 span,
.about-content h2 span {
    color: var(--primary);
}

.section-heading p {
    color: var(--text);
}


/* =========================
   ABOUT
========================= */

.about {
    background: #fff;
}

.about-grid {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 70px;
    align-items: center;
}

.about-image img {
    height: 500px;
    object-fit: cover;
    border-radius: 10px;
}

.about-content p {
    color: var(--text);
    margin-bottom: 18px;
}


/* =========================
   COURSES
========================= */

.courses {
    background: var(--light);
}

.course-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 25px;
}

.course-card {
    background: white;
    border-radius: 8px;
    overflow: hidden;
    box-shadow: 0 5px 25px rgba(0,0,0,.07);
    transition: .3s;
}

.course-card:hover {
    transform: translateY(-8px);
    box-shadow: 0 15px 35px rgba(0,0,0,.12);
}

.course-image {
    height: 220px;
    overflow: hidden;
}

.course-image img {
    height: 100%;
    object-fit: cover;
    transition: .5s;
}

.course-card:hover .course-image img {
    transform: scale(1.08);
}

.course-body {
    padding: 25px;
    position: relative;
}

.course-icon {
    width: 55px;
    height: 55px;
    background: var(--primary);
    color: white;
    display: grid;
    place-items: center;
    border-radius: 50%;
    margin-top: -50px;
    position: relative;
    margin-bottom: 15px;
}

.course-body h3 {
    margin-bottom: 10px;
}

.course-body p {
    color: var(--text);
    font-size: 14px;
    margin-bottom: 15px;
}

.course-body a {
    color: var(--primary);
    font-weight: bold;
}


/* =========================
   STATS
========================= */

.stats {
    background:
        linear-gradient(
            rgba(5,91,52,.94),
            rgba(5,91,52,.94)
        ),
        url("assets/stats-bg.jpg") center/cover;
    color: white;
    padding: 70px 0;
}

.stats-grid {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    text-align: center;
}

.stat i {
    color: var(--secondary);
    font-size: 32px;
    margin-bottom: 12px;
}

.stat strong {
    display: block;
    font-size: 38px;
}

.stat span {
    opacity: .85;
}


/* =========================
   PROJECTS
========================= */

.project-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 25px;
}

.project-card {
    border-radius: 8px;
    overflow: hidden;
    background: white;
    box-shadow: 0 5px 25px rgba(0,0,0,.08);
}

.project-card > img {
    height: 250px;
    object-fit: cover;
}

.project-content {
    padding: 25px;
}

.project-content span,
.date {
    color: var(--primary);
    font-size: 13px;
    font-weight: bold;
}

.project-content h3 {
    margin: 8px 0;
}

.project-content p {
    color: var(--text);
    font-size: 14px;
    margin-bottom: 12px;
}

.project-content a {
    color: var(--primary);
    font-weight: bold;
}


/* =========================
   CTA
========================= */

.cta {
    background: var(--primary);
    color: white;
    padding: 70px 0;
}

.cta-content {
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap: 30px;
}

.cta span {
    color: var(--secondary);
    font-size: 13px;
    font-weight: bold;
    letter-spacing: 2px;
}

.cta h2 {
    font-size: 40px;
    margin: 8px 0;
}

.cta p {
    opacity: .9;
}

.btn-light {
    background: white;
    color: var(--primary);
}


/* =========================
   BLOG
========================= */

.blog {
    background: var(--light);
}

.blog-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 25px;
}

.blog-card {
    background: white;
    box-shadow: 0 5px 20px rgba(0,0,0,.06);
}

.blog-card > img {
    height: 230px;
    object-fit: cover;
}

.blog-content {
    padding: 25px;
}

.blog-content h3 {
    margin: 10px 0;
}

.blog-content p {
    color: var(--text);
    font-size: 14px;
}

.blog-content a {
    display: inline-block;
    color: var(--primary);
    font-weight: bold;
    margin-top: 15px;
}


/* =========================
   NEWSLETTER
========================= */

.newsletter {
    background: #10231b;
    color: white;
    padding: 60px 0;
}

.newsletter-content {
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap: 40px;
}

.newsletter span {
    color: var(--secondary);
    font-size: 13px;
    font-weight: bold;
}

.newsletter h2 {
    font-size: 32px;
    margin: 5px 0;
}

.newsletter p {
    color: #bbb;
}

.newsletter form {
    display: flex;
    min-width: 450px;
}

.newsletter input {
    flex: 1;
    padding: 16px;
    border: none;
    outline: none;
}

.newsletter button {
    border: none;
    padding: 0 25px;
    background: var(--secondary);
    font-weight: bold;
    cursor: pointer;
}


/* =========================
   FOOTER
========================= */

.footer {
    background: #08140f;
    color: white;
    padding-top: 70px;
}

.footer-grid {
    display: grid;
    grid-template-columns: 1.5fr 1fr 1fr 1fr;
    gap: 50px;
    padding-bottom: 60px;
}

.footer-logo {
    display: flex;
    align-items: center;
    gap: 12px;
    margin-bottom: 20px;
}

.footer-logo img {
    width: 50px;
}

.footer-logo strong {
    display: block;
    font-size: 22px;
    color: var(--secondary);
}

.footer-logo span {
    font-size: 12px;
}

.footer-about p {
    color: #aaa;
}

.socials {
    display: flex;
    gap: 10px;
    margin-top: 20px;
}

.socials a {
    width: 40px;
    height: 40px;
    display: grid;
    place-items: center;
    background: #183126;
    border-radius: 50%;
    transition: .3s;
}

.socials a:hover {
    background: var(--primary);
}

.footer-column h3 {
    margin-bottom: 20px;
}

.footer-column a,
.footer-column p {
    display: block;
    color: #aaa;
    margin-bottom: 10px;
    font-size: 14px;
}

.footer-column a:hover {
    color: var(--secondary);
}

.footer-column i {
    color: var(--secondary);
    margin-right: 8px;
}

.copyright {
    border-top: 1px solid #1b2a23;
    padding: 20px 0;
    color: #888;
    font-size: 13px;
}


/* =========================
   SCROLL TOP
========================= */

.scroll-top {
    position: fixed;
    right: 25px;
    bottom: 25px;
    width: 45px;
    height: 45px;
    border: none;
    border-radius: 50%;
    background: var(--primary);
    color: white;
    cursor: pointer;
    opacity: 0;
    visibility: hidden;
    transition: .3s;
}

.scroll-top.show {
    opacity: 1;
    visibility: visible;
}


/* =========================
   RESPONSIVE
========================= */

@media (max-width: 992px) {

    nav {
        position: absolute;
        top: 85px;
        left: 0;
        right: 0;
        background: white;
        display: none;
        flex-direction: column;
        padding: 25px;
        box-shadow: 0 10px 20px rgba(0,0,0,.1);
    }

    nav.active {
        display: flex;
    }

    .menu-toggle {
        display: block;
    }

    .quick-grid,
    .about-grid,
    .course-grid,
    .project-grid,
    .blog-grid {
        grid-template-columns: repeat(2, 1fr);
    }

    .stats-grid {
        grid-template-columns: repeat(2, 1fr);
        gap: 35px;
    }

    .footer-grid {
        grid-template-columns: repeat(2, 1fr);
    }

    .newsletter-content,
    .cta-content {
        flex-direction: column;
        align-items: flex-start;
    }

}


@media (max-width: 650px) {

    .topbar-content {
        gap: 10px;
        font-size: 11px;
    }

    .hero {
        min-height: 580px;
    }

    .hero h1 {
        font-size: 42px;
    }

    .hero-buttons {
        flex-direction: column;
        align-items: flex-start;
    }

    .quick-grid,
    .about-grid,
    .course-grid,
    .project-grid,
    .blog-grid,
    .stats-grid,
    .footer-grid {
        grid-template-columns: 1fr;
    }

    .about-image img {
        height: 350px;
    }

    .section {
        padding: 65px 0;
    }

    .section-heading h2,
    .about-content h2 {
        font-size: 32px;
    }

    .newsletter form {
        min-width: 100%;
    }

    .newsletter form {
        flex-direction: column;
        gap: 10px;
    }

    .newsletter button {
        padding: 15px;
    }

}
