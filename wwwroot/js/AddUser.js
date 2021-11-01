let form = $('.add_test_form'),
    submitLink = form.children('.add_submit_link');

submitLink.click(function(e) {
    e.preventDefault();
    form.submit();
});