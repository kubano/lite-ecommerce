<template>
<header>
  <!-- Fixed navbar -->
  <nav class="navbar navbar-expand-md navbar-light fixed-top bg-light">
    <a class="navbar-brand" href="#">Lite E-Commerce</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarCollapse">
      <ul class="navbar-nav mr-auto">
         
        <li class="nav-item active">
          <a class="nav-link" href="#">Products <span class="sr-only">(current)</span></a>
        </li>
        <li class="nav-item">
         <a class="nav-link" href="#">Featured Products</a>
        </li>
        <li class="nav-item">
         <a class="nav-link" href="#">Promos</a>
        </li>
      </ul>
       <span class="navbar-text">
      <ul class="navbar-nav mr-auto">
        <li class="nav-item mr-2 mb-1">
             <a href="#" class="btn btn-outline-success btn-sm">
                <i class="fas fa-shopping-cart mr-1"></i><span v-show="cartItems > 0" id="js-cart-counter" class="float-right badge badge-secondary ml-2">{{ cartItems }}</span>Cart
             </a>
        </li>
        <li class="nav-item">
         <a href="#" class="btn btn-sm btn-primary text-white">
           <i class="fas fa-user-plus mr-1"></i> Sign Up
         </a>
        </li>
      </ul>
    </span>
    </div>
  </nav>
</header>

</template>

<script>
 
export default {
    name: 'Navigation',
    data() {
      return {
        cartItems: 0
      }
    },
}
</script>

<style scoped>
 
</style>
