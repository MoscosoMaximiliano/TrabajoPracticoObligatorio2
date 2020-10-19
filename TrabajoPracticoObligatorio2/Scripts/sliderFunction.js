$(function () {
    // hiding the image list so it won't look awkward when it resizes as the images load
    $("#image-list").hide();
});

// not $(document).load() since you need the images to load to know their dimensions
$(window).load(function () {
    // 10 is the scrolling speed
    $("#image-list").scrolloop(10).

        // show image list since we're all set
        slideDown(500);
});