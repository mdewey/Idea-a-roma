# Intro to Blazor!

This is a sample project for working with [Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.0)

## To get started

If you want to follow along, you will need .NET Core 3.0 install as well as a IDE (I like VS Code).

## Staring code

To follow along, create a new template and replace the contents of `Index.razor` with

```
@page "/"

<main>
  <section class="add-form">
    <form>
      <input type="text" placeholder="title" />
      <input type="text" placeholder="description" />
      <input type="text" placeholder="tagline" />
      <button class="btn btn-primary">Add idea</button>
    </form>
  </section>
  <hr />
  <section class="main-content">
    <section class="sort-buttons">
      <aside>sort by:</aside>
      <button class="btn btn-dark">title</button>
      <button class="btn btn-dark">Date</button>
    </section>
    <ul class="ideas">
      <li>
        <header>
          <h3>vr game</h3>
          <button class="btn btn-link">x</button>
        </header>
        <main>
          <p>a cool game based on som VR buzzwords</p>
          <p>a game to immerse yourself in some ML</p>
        </main>
        <footer>ideated on <time>July 31st 2019, 2:13 PM</time></footer>
      </li>
      <li>
        <header>
          <h3>vr game</h3>
          <button class="btn btn-link">x</button>
        </header>
        <main>
          <p>a cool game based on som VR buzzwords</p>
          <p>a game to immerse yourself in some ML</p>
        </main>
        <footer>ideated on <time>July 31st 2019, 2:13 PM</time></footer>
      </li>
      <li>
        <header>
          <h3>vr game</h3>
          <button class="btn btn-link">x</button>
        </header>
        <main>
          <p>a cool game based on som VR buzzwords</p>
          <p>a game to immerse yourself in some ML</p>
        </main>
        <footer>ideated on <time>July 31st 2019, 2:13 PM</time></footer>
      </li>
      <li>
        <header>
          <h3>vr game</h3>
          <button class="btn btn-link">x</button>
        </header>
        <main>
          <p>a cool game based on som VR buzzwords</p>
          <p>a game to immerse yourself in some ML</p>
        </main>
        <footer>ideated on <time>July 31st 2019, 2:13 PM</time></footer>
      </li>
      <li>
        <header>
          <h3>vr game</h3>
          <button class="btn btn-link">x</button>
        </header>
        <main>
          <p>a cool game based on som VR buzzwords</p>
          <p>a game to immerse yourself in some ML</p>
        </main>
        <footer>ideated on <time>July 31st 2019, 2:13 PM</time></footer>
      </li>
      <li>
        <header>
          <h3>vr game</h3>
          <button class="btn btn-link">x</button>
        </header>
        <main>
          <p>a cool game based on som VR buzzwords</p>
          <p>a game to immerse yourself in some ML</p>
        </main>
        <footer>ideated on <time>July 31st 2019, 2:13 PM</time></footer>
      </li>
    </ul>
  </section>
</main>

```

And the contents `wwwroot/css/site.css` with

```css
@import url('open-iconic/font/css/open-iconic-bootstrap.min.css');
html,
body {
  font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif;
}

app {
  position: relative;
  display: flex;
  flex-direction: column;
}

app > .main {
  padding: 1rem;
  width: 100%;
  display: flex;
  justify-content: center;
}

.add-form {
  width: 100%;
  display: flex;
  justify-content: center;
}

.main-content {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

.sort-buttons {
  display: flex;
  justify-content: space-between;
  width: 25%;
}

.ideas {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  width: 100%;
}

.ideas > li {
  background-color: yellow;
  box-shadow: 5px 5px 5px 0px rgba(0, 0, 0, 0.75);
  flex-basis: 45%;
  padding: 1rem;
  margin: 1rem;
}

.ideas > li > header {
  display: flex;
  justify-content: space-between;
  border-bottom: 1px solid lightgray;
}

.ideas > li > footer {
  border-top: 1px solid lightgray;
  font-size: 0.75rem;
}

.ideas > li > header > button {
  color: red;
  font-size: 1.1rem;
}

main {
  width: 100%;
}

.btn {
  text-transform: uppercase;
  font-size: 0.75rem;
}

ul {
  list-style: none;
}
```

Update the `MainLayout.razor` component to have this code

```
@inherits LayoutComponentBase

<nav class="navbar navbar-light bg-light">
  <span class="navbar-brand mb-0 h1">Ideas that I will totally get to some day</span>
</nav>
<div class="main">

        @Body

</div>
```
