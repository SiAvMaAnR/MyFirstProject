let form = $('.del_test_form'),
    submitLink = form.children('.del_submit_link');

submitLink.click(function(e) {
    e.preventDefault();
    form.submit();
});