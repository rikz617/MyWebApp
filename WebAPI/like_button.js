'use strict';

const e = React.createElement;

class LikeButton extends React.Component {
    constructor(props) {
        super(props);
        this.state = { liked: false };
    }

    render() {
        if (this.state.liked) {
            return 'You liked this.';
        }

        return e(
            'button',
            { onClick: () => this.setState({ liked: true }) },
            'Like'
        );
    }
}


class DontLikeButton extends React.Component {
    constructor(props) {
        super(props);
        this.state = { dontliked: false };
    }

    render() {
        if (this.state.dontliked) {
            return 'You dont liked this.';
        }

        return e(
            'button',
            { onClick: () => this.setState({ dontliked: true }) },
            'DontLike'
        );
    }
}



// ... the starter code you pasted ...

const domContainer = document.querySelector('#like_button_container');
ReactDOM.render(e(LikeButton), domContainer);



