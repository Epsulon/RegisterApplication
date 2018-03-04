<script>
    var openInbox = document.getElementById("myBtn");
        openInbox.click();

        function tk_open() {
        document.getElementById("mySidebar").style.display = "block";
    document.getElementById("myOverlay").style.display = "block";
        }
        function tk_close() {
        document.getElementById("mySidebar").style.display = "none";
    document.getElementById("myOverlay").style.display = "none";
        }

        function myFunc(id) {
            var x = document.getElementById(id);
            if (x.className.indexOf("tk-show") == -1) {
        x.className += " tk-show";
    x.previousElementSibling.className += " tk-red";
            } else {
        x.className = x.className.replace(" tk-show", "");
    x.previousElementSibling.className =
                    x.previousElementSibling.className.replace(" tk-red", "");
            }
        }

        openMail("Borge")
        function openMail(personName) {
            var i;
            var x = document.getElementsByClassName("person");
            for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
            x = document.getElementsByClassName("test");
            for (i = 0; i < x.length; i++) {
        x[i].className = x[i].className.replace(" tk-light-grey", "");
    }
            document.getElementById(personName).style.display = "block";
            event.currentTarget.className += " tk-light-grey";
        }
    </script>

    <script>
        var openTab = document.getElementById("firstTab");
        openTab.click();
    </script>