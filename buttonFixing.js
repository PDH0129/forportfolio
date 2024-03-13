window.addEventListener('resize', function() {
  const postDiv = document.querySelector('.post');
  const leftOffset = window.innerWidth * 0.7; // 왼쪽에서 70% 위치 계산
  postDiv.style.left = leftOffset + 'px';
});