from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def home():
    return render_template('website_phongtro.html')
@app.route('/phong_coban.html')
def phong_coban():
    return render_template('phong_coban.html')

@app.route('/phong_plus.html')
def phong_plus():
    return render_template('phong_plus.html')
@app.route('/phong_fullnt.html')
def phong_fullnt():
    return render_template('phong_fullnt.html')
@app.route('/gioithieu.html')
def gioithieu():
    return render_template('gioithieu.html')


if __name__ == '__main__':
    app.run(debug=True)
