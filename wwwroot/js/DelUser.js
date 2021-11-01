let Delform = $(".del_test_form"),
  DelLink = Delform.children(".del_submit_link");

DelLink.click(function (e) {
  e.preventDefault();
  Delform.submit();
});
