function openModal(img) {
    const modal = document.getElementById("modal");
    const modalImg = document.getElementById("modal-img");
    const caption = document.getElementById("caption");

    modal.style.display = "flex";
    modalImg.src = img.src;
    caption.innerHTML = img.nextElementSibling.innerHTML;
}

function closeModal() {
    document.getElementById("modal").style.display = "none";
}
document.addEventListener("DOMContentLoaded", function() {
    // Hiển thị nút khi người dùng cuộn xuống 200px từ đỉnh trang
    window.onscroll = function() {scrollFunction()};

    function scrollFunction() {
        const scrollToTopBtn = document.getElementById("scrollToTopBtn");
        if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
            scrollToTopBtn.style.display = "block";
        } else {
            scrollToTopBtn.style.display = "none";
        }
    }

    // Khi người dùng nhấn vào nút, cuộn lên đầu trang với hiệu ứng mượt mà
    document.getElementById('scrollToTopBtn').addEventListener('click', function(){
        window.scrollTo({ top: 0, behavior: 'smooth' });
    });
});
