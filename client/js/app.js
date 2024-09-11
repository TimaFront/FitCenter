// ----- anchor(snoothScroll) -----

let smoothScroll = document.querySelectorAll('[data-scroll]');
for (anchor of smoothScroll) {
    if (anchor) {
        anchor.addEventListener('click', function(event){
            event.preventDefault();
            anchorID = this.getAttribute('data-scroll');
            document.querySelector(anchorID).scrollIntoView({
                behavior: 'smooth', block: 'start'
            })
        })
    }
}

// ----- header fixed -----
	
let header = document.getElementById('header');
window.onscroll = function() {scrollFunction()};

function scrollFunction() {

	if( document.body.scrollTop > 100 // если количество прокрученных пикселей от вверха элемента body больше чем 100 
		|| document.documentElement.scrollTop > 100) //позволяет получить доступ к коренному элементу документа/к вершине DOM-дерева. P.S. без этого не робит
	{
		header.classList.add('fixed');
	} else {
		header.classList.remove('fixed');
	}
};

// ----- burger menu -----
 
const navToggle = document.querySelector('#nav__toggle');
const nav = document.querySelector('#nav');
    
navToggle.addEventListener('click', function(){
    navToggle.classList.toggle('active');
    nav.classList.toggle('active');
});

// ----- accordion -----

function show_list() {
    document.getElementById("accordionId").classList.toggle("show");
}
  
window.onclick = function(event) {
    if (!event.target.matches('.nav__link')) {
        let accord = document.getElementsByClassName("accordion__info-content");
        let i;
        for (i = 0; i < accord.length; i++) {
            let openAccord = accord[i];
            if (openAccord.classList.contains('show')) {
                openAccord.classList.remove('show');
            }
        }
    }
}

// ----- help -----

function openForm() {
    document.getElementById("myForm").style.display = "block";
}
  
function closeForm() {
    document.getElementById("myForm").style.display = "none";
}

// ----- popup -----

const modalButtons = document.querySelectorAll('[data-modal-button]');
const modalClosebuttons = document.querySelectorAll('[data-modal-close]');
const allModals = document.querySelectorAll('[data-modal]');

// Кнопки - Открыть Модалку

modalButtons.forEach(function (item) {
    item.addEventListener('click', function () {
		const modalId = this.dataset.modalButton;
		const modal = document.querySelector('#' + modalId);
		modal.classList.add('active');

		// Находим внутри открываемой модалки блок .modal-window и запрещаем ему передавать клики "наверх"
		modal.querySelector('.popup-wrap').addEventListener('click', function (e) {
			e.stopPropagation();
		});
	})
})

// Кнопки - Закрыть Модалку
modalClosebuttons.forEach(function (item) {
    item.addEventListener('click', function () {
        const modal = this.closest('[data-modal]');
        modal.classList.remove('active');
    })
})

// ----- slide -----

let slideIndex = 1;
showSlides(slideIndex);

function plusSlide() {
    showSlides(slideIndex += 1);
}

function minusSlide() {
    showSlides(slideIndex -= 1);  
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    let i;
    const slides = document.querySelectorAll('[data-slayd]')
    const dots = document.querySelectorAll('[data-slayd-content]');
    if (n > slides.length) {
        slideIndex = 1
    }
    if (n < 1) {
        slideIndex = slides.length;
    }
    for (let i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (let i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace("active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += "active";
}
let i = 1;
    setInterval(function(){
    currentSlide(i)
    i++;
    if (i == 7)
    {
        i = 1;
    }
},5000)

// form 

const form = document.getElementById('form');
form.addEventListener('submit', getFormValue);
function getFormValue(event) {
    event.preventDefault();
    const name = form.querySelector('[name="name"]'); 
    const data = {
        name: name.value
    };
}
