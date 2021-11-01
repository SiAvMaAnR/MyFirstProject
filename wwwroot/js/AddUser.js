let Addform = $(".add_test_form"),
  AddLink = Addform.children(".add_submit_link");

AddLink.click(function (e) {
  e.preventDefault();
  Addform.submit();
});
