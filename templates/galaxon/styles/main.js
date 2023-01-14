function appendProfileLink() {
    if ($('.navbar-nav').length > 0) {
        $('#navbar').append(`<div id="profile-link"><a href="https://github.com/mossy2100">
                <img alt="Shaun Moss avatar" width="30" height="30" src="https://avatars.githubusercontent.com/u/371497?v=4">
                <label>My GitHub profile</label>
            </a></div>`);
    }
    else {
        window.setTimeout(appendProfileLink, 100);
    }
}

function fixHeights() {

}

$(appendProfileLink);
