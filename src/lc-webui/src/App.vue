<template>
  <div id="app">
    <Navigation />
    <Home />
  </div>
</template>
<script>
import "@fortawesome/fontawesome-free/css/all.css";
import Navigation from "./components/Navigation";
import Home from './views/Home'
export default {
  components: {
    Navigation,
    Home
  },
};
</script>
<style>
@import url("https://fonts.googleapis.com/css2?family=Open+Sans:wght@400;700&family=Roboto:wght@400;900&display=swap");
#app {
  font-family: "Open Sans", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  margin-top: 3.3em;
}
.footer {
  position: absolute;
  bottom: 0;
  width: 100%;

  background-color: #f5f5f5;
}
</style>
