(function($) {
  "use strict"; // Start of use strict

  // Smooth scrolling using jQuery easing
  $(document).on("click", ".js-scroll-trigger", (function () {
      if ((location.hostname == this.hostname) || this.id) {
          var sectionsHref = this.id ? this.id.indexOf("batches") != -1 ? "#batches" : this.id.indexOf("facilities") != -1 ? "#facilities" : "" : this.hash;
          if (sectionsHref != "") {
              var target = $(sectionsHref), scrollTop = 0;
              target = target.length ? target : $('[name=' + sectionsHref.slice(1) + ']');


             

              if (this.id ==""){
                  $(".js-scroll-trigger").each(function () {
                      $(this).removeClass("link-active");
                  });
                  $(this).addClass("link-active");
              }                 
              else {
                  if (sectionsHref.indexOf("batches") != -1) {
                      $("#batcheslink").addClass("link-active");
                  }
                  else {
                      $("#facilitieslink").addClass("link-active");
                  }
              }

              if (target.length) {
                  scrollTop = sectionsHref && sectionsHref.indexOf("home") ? 0 : target.offset().top;
                  $('html, body').animate({
                      scrollTop: (target.offset().top - 54)
                  }, 2000, "easeInOutExpo");
                  return false;
              }
          }
      }
  }));

  // Closes responsive menu when a scroll trigger link is clicked
  $('.js-scroll-trigger').click(function() {
    $('.navbar-collapse').collapse('hide');
  });

  // Activate scrollspy to add active class to navbar items on scroll
  $('body').scrollspy({
    target: '#mainNav',
    offset: 54
  });

})(jQuery); // End of use strict
